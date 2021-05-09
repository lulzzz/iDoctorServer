﻿using AN.Core.Models;
using Microsoft.Extensions.Options;
using RestSharp;
using Shared.Settings;
using System;
using System.Threading.Tasks;

namespace AN.BLL.Core.Services.Messaging.SMS.Kurtename
{
    public class KurtenameSmsService : IKurtenameSmsService
    {
        private readonly IRestClient _client;

        private readonly IOptions<AppSettings> _settings;
        public KurtenameSmsService(IOptions<AppSettings> options)
        {
            _settings = options;
            _client = new RestClient(BaseUrl);
        }

        private string BaseUrl => _settings.Value.AwroNoreSettings.KurtenameSmsOptions.BaseUrl;

        private string ApiKey => _settings.Value.AwroNoreSettings.KurtenameSmsOptions.ApiKey;

        private string SourceAddress => _settings.Value.AwroNoreSettings.KurtenameSmsOptions.SourceAddress;

        private bool Unicode => _settings.Value.AwroNoreSettings.KurtenameSmsOptions.Unicode;

        public async Task<T> ExecuteAsync<T>(RestRequest request) where T : new()
        {
            request.AddHeader("x-api-key", ApiKey);

            var response = await _client.ExecuteAsync<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response. Check inner details for more info.";

                var customException = new Exception(message, response.ErrorException);

                throw customException;
            }
            return response.Data;
        }

        public async Task SendSmsAsync(string mobile, string message)
        {
            try
            {
                var smsModel = new KurtenameSmsModel
                {
                    SourceAddr = SourceAddress,
                    DestAddr = mobile,
                    Unicode = Unicode,
                    MessageText = message
                };

                var request = new RestRequest(Method.POST)
                {
                    RequestFormat = DataFormat.Json
                };

                request.AddJsonBody(smsModel);

                var result = await ExecuteAsync<KurtenameSmsResultModel>(request);
            }
            catch
            {
                throw;
            }
        }
    }
}
