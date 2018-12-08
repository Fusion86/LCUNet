using LCUNet.Models;
using System;

namespace LCUNet.Exceptions
{
    public class LeagueClientException : Exception
    {
        public LeagueClientError Error { get; }

        public LeagueClientException(LeagueClientError error) : base(error.Message)
        {
        }
    }
}
