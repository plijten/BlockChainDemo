
# Ganache Blockchain Transaction with C#

Dit project demonstreert hoe je een transactie kunt uitvoeren op een lokale Ethereum blockchain (via Ganache) met behulp van C# en de Nethereum-bibliotheek.

### Functionaliteiten
- Verbindt met een lokale Ganache-blockchain (Ethereum-simulator).
- Voert een eenvoudige Ether-transactie uit tussen twee accounts op het netwerk.
- Geschreven in C# en maakt gebruik van de **Nethereum**-bibliotheek.

### Vereisten
- **Ganache**: Lokale Ethereum blockchain-simulator.
- **C#**: Versie 8.0 of hoger.
- **.NET Core SDK**: Versie 3.1 of hoger.
- **Nethereum.Web3** NuGet-pakket.

### Installatie

1. **Installeer Ganache**  
   Download en installeer Ganache van [Truffle Suite](https://www.trufflesuite.com/ganache). Start Ganache en zorg ervoor dat het draait op `http://127.0.0.1:7545` met network ID `5777`.

De APPX bestand voor de installatie in Windows is bijgesloten in de repo omdat Ganache op dit moment niet verder ontwikkeld wordt.

2. **Clone het project**
   ```bash
   git clone https://github.com/jouw-gebruikersnaam/ganache-csharp-transaction.git
   cd ganache-csharp-transaction
   ```

3. **Installeer Nethereum-pakketten**
   Gebruik de NuGet Package Manager of voer de volgende command uit in de NuGet Console:
   ```bash
   Install-Package Nethereum.Web3
   ```

4. **Configureer het project**
   - Open `Program.cs` en vervang de placeholders voor `senderAddress`, `receiverAddress` en `privateKey` met de juiste gegevens die je van Ganache hebt.

5. **Voer het project uit**
   ```bash
   dotnet run
   ```

Als de transactie succesvol wordt uitgevoerd, wordt de transactieresultaat-hash in de console weergegeven.

### Structuur van het project
- `Program.cs`: Het hoofdbestand waarin de verbinding met de blockchain wordt opgezet en de transactie wordt uitgevoerd.

### Verdere informatie
- **Ganache** is een krachtige tool voor het lokaal ontwikkelen en testen van Ethereum smart contracts en transacties.
- **Nethereum** is een C#-bibliotheek voor het interactief communiceren met het Ethereum blockchain-ecosysteem.

### Licentie
Dit project is gelicentieerd onder de MIT-licentie.
