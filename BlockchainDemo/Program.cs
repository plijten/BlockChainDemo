// Verbinding maken met het lokale Ganache netwerk
using Nethereum.Web3;

var url = "http://127.0.0.1:7545";
var web3 = new Web3(url);

// Adressen van afzender en ontvanger (let op dat deze overeenkomen met je Ganache-accounts)
var senderAddress = "0x3e7A5cF557738DF3F6DC08F4d14F1Eb2fa9b1f43";  // Vervang dit met een geldig Ganache-adres
var receiverAddress = "0x0966bb5D16798Aa8694195a68C42A0B4543F14f5";  // Vervang dit met een ander Ganache-adres

// Private key van de afzender
var privateKey = "0xb049f7fedf2e2797df543553d81953f24c83c6a1d957d654460ce2102fcd7aff"; // Vervang dit met de private key van de afzender in Ganache

// Maak een accountobject aan
var account = new Nethereum.Web3.Accounts.Account(privateKey);
web3 = new Web3(account, url);

// Transactiedetails
var amountInEther = 0.1m;  // Het bedrag in Ether dat je wilt overmaken
var gas = 21000;  // Het standaard gaslimiet voor eenvoudige transfers

// Transactie versturen
try
{
    var transactionHash = await web3.Eth.Transactions.SendTransaction.SendRequestAsync(new Nethereum.RPC.Eth.DTOs.TransactionInput
    {
        From = senderAddress,
        To = receiverAddress,
        Value = new Nethereum.Hex.HexTypes.HexBigInteger(Nethereum.Util.UnitConversion.Convert.ToWei(amountInEther)),
        Gas = new Nethereum.Hex.HexTypes.HexBigInteger(gas)
    });

    Console.WriteLine($"Transactie succesvol. Hash: {transactionHash}");
}
catch (Exception ex)
{
    Console.WriteLine($"Er is een fout opgetreden: {ex.Message}");
}
