﻿using AWRO.Helper.UIHelper.Attributes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace AWRO.Helper.UIHelper.Grid
{
    public static class AWROComponent
    {
        public static HtmlString JGrid2<TModel, TValue>(this IHtmlHelper<TModel> html, string gridName,string objectName, bool showPaging, bool showFooter, bool isReadOnlyGrid, Dictionary<string, bool> showIfParameters)
        {
            showPaging = false;
            var mainDiv = new AwroTagBuilder("div");
            mainDiv.MergeAttribute("class", "row fourth six");
            mainDiv.MergeAttribute("id", gridName);

            var properties = typeof(TValue).GetProperties();
            properties=setOrders(properties);
            if (showIfParameters != null)
            {
                var doNotShowList = showIfParameters.Where(c => !c.Value);
                if (doNotShowList != null && showIfParameters.Count() > 0)
                {
                    var shareList = properties.Join(doNotShowList, c => c.Name, c => c.Key, (first, second) => first);
                    properties = properties.Except(shareList).ToArray();
                }
            }
            mainDiv.InnerHtml += createHeaderColumnsList(properties, gridName, objectName,isReadOnlyGrid);
            mainDiv.InnerHtml += createNewRow(properties, gridName);

            var secondDiv = new AwroTagBuilder("div");
            secondDiv.MergeAttribute("class", "col-sm-12");

            var holderDive = new AwroTagBuilder("div");
            holderDive.MergeAttribute("class", "col-sm-12");
            holderDive.MergeAttribute("style", "padding:0;");

            var hasWaitingDiv = new AwroTagBuilder("div");
            hasWaitingDiv.MergeAttribute("class", "has-waiting table-responsive");

            var mainTable = new AwroTagBuilder("table");
            mainTable.MergeAttribute("class", "table table-bordered table-hover inline-edit");

            renderTable(mainTable, properties, showFooter);

            hasWaitingDiv.InnerHtml += mainTable.ToString();
            var waitingDiv = new AwroTagBuilder("div");
            waitingDiv.MergeAttribute("class", "waiting");
            waitingDiv.MergeAttribute("style", "display:none");
            var spanWaiting = new AwroTagBuilder("span");
            waitingDiv.InnerHtml += spanWaiting;
            hasWaitingDiv.InnerHtml += waitingDiv;

            holderDive.InnerHtml += hasWaitingDiv;

            secondDiv.InnerHtml += holderDive;
            if (showPaging)
            {
                var nav = createNavigation();
                secondDiv.InnerHtml += nav.ToString();
            }

            mainDiv.InnerHtml += secondDiv.ToString();

            // initiateGrid(gridName, mainDiv);
            return new HtmlString(mainDiv.ToString());

        }
        private static PropertyInfo[] setOrders(PropertyInfo[] properties)
        {
            if (properties != null)
            {
                var haveOrdersList = properties.Where(c => c.GetCustomAttribute<AwroGridOrder>() != null)
                     .OrderBy(c => c.GetCustomAttribute<AwroGridOrder>().Value).ToList();
                var doNotHaveOrdersList = properties.Where(c => c.GetCustomAttribute<AwroGridOrder>() == null);
                var tempResult = new List<PropertyInfo>();
                tempResult = tempResult.Concat(haveOrdersList).ToList();
                tempResult = tempResult.Concat(doNotHaveOrdersList).ToList();
                properties = tempResult.ToArray();
            }

            return properties;
        }
        private static AwroTagBuilder createNavigation()
        {
            var nav = new AwroTagBuilder("nav");
            nav.MergeAttribute("aria-label", "Page navigation");
            var ul = new AwroTagBuilder("ul");
            ul.MergeAttribute("class", "pagination border");
            ul.InnerHtml += createNavButton("First", "&laquo;");
            ul.InnerHtml += createNavButton("Previous", "&lsaquo;");

            ul.InnerHtml += createNavInfo();

            ul.InnerHtml += createNavButton("Next", "&rsaquo;");
            ul.InnerHtml += createNavButton("Last", "&raquo;");
            nav.InnerHtml += ul;
            return nav;
        }
        private static AwroTagBuilder createNavInfo()
        {
            var li = new AwroTagBuilder("li");
            li.MergeAttribute("class", "page-item");
            var input = new AwroTagBuilder("input");
            input.MergeAttribute("class", "paging-num page-link border-left border-right");
            input.MergeAttribute("type", "text");
            input.MergeAttribute("name", "page");
            input.MergeAttribute("value", " ");
            li.InnerHtml += input;
            return li;
        }

        private static AwroTagBuilder createNavButton(string name, string icone)
        {
            var liPrevious = new AwroTagBuilder("li");
            liPrevious.MergeAttribute("class", "page-item");
            var a = new AwroTagBuilder("a");
            a.MergeAttribute("class", (name == "First" ? "border-right" : name == "Last" ? "border-left" : "border-left border-right") + " page-link " + name);
            a.MergeAttribute("href", "#");
            var tooltip = name == "First" ? Resources.AwroGrid.First : (name == "Previous" ? Resources.AwroGrid.Previous : (name == "Next" ? Resources.AwroGrid.Next : Resources.AwroGrid.Last));
            a.MergeAttribute("title", tooltip);
            a.MergeAttribute("aria-label", "Next");

            var firstSpan = new AwroTagBuilder("span");
            firstSpan.MergeAttribute("aria-hidden", "true");
            firstSpan.InnerHtml += icone;

            var secondSpan = new AwroTagBuilder("span");
            secondSpan.MergeAttribute("class", "sr-only");
            secondSpan.InnerHtml += name;
            a.InnerHtml += firstSpan;
            a.InnerHtml += secondSpan;
            liPrevious.InnerHtml += a;
            return liPrevious;
        }
        private static AwroTagBuilder createPaginationSpan(string className, string title, string iClass)
        {
            var span = new AwroTagBuilder("span");
            span.MergeAttribute("Class", className);
            span.MergeAttribute("title", title);
            var i = new AwroTagBuilder("i");
            i.MergeAttribute("class", iClass);
            span.InnerHtml += i;
            return span;
        }

        private static void renderTable(AwroTagBuilder mainTable, PropertyInfo[] properties, bool showFooter)
        {
            if (properties != null && properties.Count() > 0)
            {
                renderHeader(mainTable, properties);
                renderBody(mainTable);
                if (showFooter)
                    renderFooter(mainTable, properties);
            }
        }

        private static void renderFooter(AwroTagBuilder mainTable, PropertyInfo[] properties)
        {
            var footer = new AwroTagBuilder("tfoot");
            var footerTr = new AwroTagBuilder("tr");
            foreach (var item in properties)
            {
                if (item.GetCustomAttribute<DoNotShow>() == null)
                {
                    insertToFooter(footerTr, item);
                }
            }
            footer.InnerHtml += footerTr.ToString();
            mainTable.InnerHtml += footer.ToString();
        }

        private static void renderHeader(AwroTagBuilder mainTable, PropertyInfo[] properties)
        {
            var tableHead = new AwroTagBuilder("thead");
            var headTr = new AwroTagBuilder("tr");
            var isCheckedItem = properties.FirstOrDefault(c => c.Name == "IsChecked");
            if (isCheckedItem != null)
                insertToHeader(headTr, isCheckedItem);
            var rownIndexItem = properties.FirstOrDefault(c => c.Name == "RowIndex");
            if (rownIndexItem != null)
                insertToHeader(headTr, rownIndexItem);
            foreach (var item in properties)
            {
                if (item.Name != "RowIndex" && item.Name != "IsChecked")
                {
                    if (item.GetCustomAttribute<DoNotShow>() == null)
                    {
                        insertToHeader(headTr, item);
                    }
                }
            }
            tableHead.InnerHtml += headTr.ToString();
            mainTable.InnerHtml += tableHead.ToString();
        }
        private static void renderBody(AwroTagBuilder mainTable)
        {
            var tbody = new AwroTagBuilder("tbody");
            mainTable.InnerHtml += tbody.ToString();
        }

        private static void insertToHeader(AwroTagBuilder headTr, PropertyInfo item)
        {
            var th = new AwroTagBuilder("th");
            th.MergeAttribute("scope", "col");
            if (item.GetCustomAttribute<AwroGridWidth>() != null)
            {
                th.MergeAttribute("style", "width:" + item.GetCustomAttribute<AwroGridWidth>().Value);
            }
            th.InnerHtml += item.GetCustomAttribute<DisplayAttribute>() != null ? item.GetCustomAttribute<DisplayAttribute>().GetName() : item.Name;
            headTr.InnerHtml += th.ToString();
        }
        private static void insertToFooter(AwroTagBuilder footerTag, PropertyInfo item)
        {
            var td = new AwroTagBuilder("td");
            if (item.GetCustomAttribute<AwroGridWidth>() != null)
            {
                td.MergeAttribute("style", "width:" + item.GetCustomAttribute<AwroGridWidth>().Value);
            }
            //td.InnerHtml += item.GetCustomAttribute<DisplayAttribute>() != null ? item.GetCustomAttribute<DisplayAttribute>().GetName() : item.Name;
            footerTag.InnerHtml += td.ToString();
        }

        private static string createHeaderColumnsList(PropertyInfo[] properties, string gridName, string objectName, bool isReadOnlyGrid)
        {
            var result = "<script>";
            result += "\n  var _headerColumnsList_" + gridName + " = [];";
            result += "\n $(function(){";
            if (properties != null && properties.Count() > 0)
            {
                var rownIndexItem = properties.FirstOrDefault(c => c.Name == "RowIndex");
                if (rownIndexItem != null)
                    result = addHeaderItem(result, objectName, rownIndexItem, gridName, isReadOnlyGrid);
                foreach (var item in properties)
                {
                    if (item.Name != "RowIndex")
                    {
                        result = addHeaderItem(result, objectName, item, gridName, isReadOnlyGrid);
                    }
                }
            }
            result += "});";
            result += "</script>";
            return result;
        }
        private static string createNewRow(PropertyInfo[] properties, string gridName)
        {
            var result = "<script>";
            result += "\n  var _newRow_" + gridName + " ={";
            if (properties != null && properties.Count() > 0)
            {
                foreach (var item in properties)
                {
                    result += item.Name.Substring(0, 1).ToLower() + (item.Name.Length >= 2 ? item.Name.Substring(1, item.Name.Length - 1) : "") + ":'',";
                }
                result = result.Substring(0, result.Length - 1);
            }
            result += "};";
            result += "</script>";
            return result;
        }

        private static string addHeaderItem(string result, string objectName, PropertyInfo item, string gridName,bool isReadOnlyGrid)
        {
            result += "\n _headerColumnsList_" + gridName + ".push({";
            result += "Name:'" + item.Name.Substring(0, 1).ToLower() + item.Name.Substring(1, item.Name.Length - 1) + "'";
            result = readWidth(result, item);
            result = readTypes(result, objectName, item);
            result = readReadOnly(result, item, isReadOnlyGrid);
            result = readDonNotShow(result, item);
            result = readDropDown(result, objectName, item);
            result = readIsRequired(result, item);
            result += "});";
            return result;
        }
        private static string readWidth(string result, PropertyInfo item)
        {
            if (item.GetCustomAttribute<AwroGridWidth>() != null)
            {
                result += ",Width:'" + item.GetCustomAttribute<AwroGridWidth>().Value + "'";
            }

            return result;
        }
        private static string readReadOnly(string result, PropertyInfo item, bool isReadOnlyGrid)
        {
            result += ",ReadOnly:'" + (item.GetCustomAttribute<ReadOnly>() != null || item.GetCustomAttribute<JGridRenderer>() != null) + "'";
            result += ",ReadOnlyGrid:'" + isReadOnlyGrid + "'";
            return result;
        }
        private static string readIsRequired(string result, PropertyInfo item)
        {
            result += ",IsRequired:'" + (item.GetCustomAttribute<RequiredAttribute>() != null) + "'";
            return result;
        }
        private static string readDonNotShow(string result, PropertyInfo item)
        {
            result += ",Show:'" + (item.GetCustomAttribute<DoNotShow>() == null) + "'";
            return result;
        }
        private static string readDropDown(string result,string objectName,PropertyInfo item)
        {
            if (item.GetCustomAttribute<DropDownList>() != null)
            {
                var dataSourceName = !string.IsNullOrEmpty(objectName) ? objectName + "." + item.GetCustomAttribute<DropDownList>().DataSource 
                    : item.GetCustomAttribute<DropDownList>().DataSource;
                result += ",DropDown:'True',DropDownDataSource:'" + dataSourceName + "'";
            }
            return result;
        }
        private static string readTypes(string result,string objectName, PropertyInfo item)
        {
            if (item.GetCustomAttribute<JGrid2Delete>() != null)
            {
                result += ",Type:'delete'";
            }
            else if (item.GetCustomAttribute<JGridRenderer>() != null)
            {
                var customName = !string.IsNullOrEmpty(objectName) ? objectName + "." + item.GetCustomAttribute<JGridRenderer>().Name
                 : item.GetCustomAttribute<JGridRenderer>().Name; 
                result += ",Type:'custome',CustomeRender:'" + customName + "'";
            }
            else if (item.PropertyType == typeof(bool))
            {
                result += ",Type:'bool'";
            }
            else if (item.PropertyType == typeof(int))
            {
                result += ",Type:'int'";
            }
            else if (item.PropertyType == typeof(float))
            {
                result += ",Type:'float'";
            }
            else if (item.PropertyType == typeof(decimal))
            {
                result += ",Type:'decimal'";
            }
            else if (item.PropertyType == typeof(string))
            {
                result += ",Type:'string'";
            }
            else if (item.PropertyType == typeof(DateTime) || item.PropertyType == typeof(DateTime?))
            {
                result += ",Type:'date'";
            }

            return result;
        }
    }
}
