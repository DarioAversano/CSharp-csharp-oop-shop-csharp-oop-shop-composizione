// See https://aka.ms/new-console-template for more information

using CSharp_Composizione_Shop;

//Prodotto myProdotto = new Prodotto("Bottiglia", "Acqua", 1.5f, 10);

//Console.WriteLine("Cambia nome al prodotto: ");
//myProdotto.Name = Console.ReadLine();

//Console.WriteLine("Nome : " + myProdotto.Name);
//Console.WriteLine("Descrizione : " + myProdotto.Description);
//Console.WriteLine("Prezzo : " + myProdotto.Price);
//Console.WriteLine("Codice : " + myProdotto.Code);
//Console.WriteLine("Codice Formattato : " + myProdotto.FormattedNum());
//Console.WriteLine("Codice Formattato PadLeft: " + myProdotto.getFormattedCodePadLeft8());
//Console.WriteLine("Codice + Nome : " + myProdotto.CodeName());

//Console.WriteLine("Il Prezzo Base è : " + myProdotto.GetPrezzoBase());
//Console.WriteLine("Il Prezzo con Iva invece è : " + myProdotto.GetPrezzoIva());

/*
Avvalendosi della "composizione" e usando quanto già fatto nella vostra classe Prodotto, 

si possa inserire la lista di prodotti inziali o eventualmente una lista di prodotti nuovi che tratterò in più da oggi in poi nel negozio.
si possa inserire anche un prodotto singolo in più al negozio
si possa chiedere ad uno shop di darmi la sua rappresentazione in stringa e io possa stamparla in Console.

A questo punto provate a creare qualche prodotto, ed inserirlo in una lista di prodotti iniziali. 
Create il vostro shop e aggiungetegli la lista iniziale dei prodotti. Stampate le informazioni del negozio (avvalendovi del metodo fatto nel negozio) 
e assicuratevi che i prodotti iniziali (o aggiunti anche successivamente) vengano stampati bene e in maniera corretta nel modo corretto visto in classe.
Provate ad aggiungere un nuovo prodotto allo shop, o una lista nuova di prodotti che volete che lo shop tratti e provate a ristampare le informazioni del negozio con i 
nuovi prodotti via via aggiornati in Console.Aggiungete poi ai vostri prodotti anche una Categoria ( o Category ) avvalendovi sempre del metodo della composizione, 
questa volta dentro il vostro Prodotto, in modo che potete tenere traccia della categoria di ogni prodotto. 
La categoria, oltre al semplice nome, potrebbe avere una descrizione e un codice identificativo ad uso interno.

*/

Shop shop1 = new Shop("Drinkshop", "Roma", "Via Garibaldi", "99");

Console.WriteLine("Nome Shop prima del cambio : " + shop1.Nome);


Console.WriteLine("Immetti il nome dello shop: ");
shop1.Nome = Console.ReadLine();

Console.WriteLine("Numero civico shop: ");
shop1.NumeroCivico = Console.ReadLine();

Console.WriteLine("Nome Shop : " + shop1.Nome);
Console.WriteLine("Citta Shop : " + shop1.Citta);
Console.WriteLine("Indirizzo Shop : " + shop1.Indirizzo);
Console.WriteLine("Numero Civico Shop : " + shop1.NumeroCivico);