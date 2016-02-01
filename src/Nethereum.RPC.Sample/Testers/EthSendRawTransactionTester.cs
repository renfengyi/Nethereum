using System;
using System.Threading.Tasks;
using edjCase.JsonRpc.Client;
using Nethereum.RPC.Eth;

namespace Nethereum.RPC.Sample.Testers
{
    public class EthSendRawTransactionTester : IRPCRequestTester
    {
        public async Task<dynamic> ExecuteTestAsync(RpcClient client)
        {
            var ethSendRawTransaction = new EthSendRawTransaction(client);
            return await ethSendRawTransaction.SendRequestAsync( "0xd46e8dd67c5d32be8d46e8dd67c5d32be8058bb8eb970870f072445675058bb8eb970870f072445675");
        }

        public Type GetRequestType()
        {
            return typeof(EthSendRawTransaction);
        }
    }
}
        