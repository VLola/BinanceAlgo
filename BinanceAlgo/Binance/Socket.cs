using Binance.Net.Clients;
using Binance.Net.Interfaces.Clients.UsdFuturesApi;
using BinanceAlgo.Errors;
using CryptoExchange.Net.Authentication;
using System;

namespace BinanceAlgo.Binance
{
    public class Socket
    {
        public string ApiKey { get; private set; }
        public string SecretKey { get; private set; }
        public BinanceClient client = new BinanceClient();
        public BinanceSocketClient socketClient = new BinanceSocketClient();
        public IBinanceClientUsdFuturesApi futures { get; set; }
        public IBinanceSocketClientUsdFuturesStreams futuresSocket { get; set; }
        public Socket(string api, string secret)
        {
            ApiKey = api;
            SecretKey = secret;
            client.SetApiCredentials(new ApiCredentials(ApiKey, SecretKey));
            socketClient = new BinanceSocketClient();
            socketClient.SetApiCredentials(new ApiCredentials(ApiKey, SecretKey));
            futures = client.UsdFuturesApi;
            futuresSocket = socketClient.UsdFuturesStreams;
        }
    }
}
