<Query Kind="Statements" />

// Use the LINQ XML classes to create an XML tree
// procedural way
XElement card = new XElement("Card");
card.Add(new XAttribute("card-name", "Mingle"));
card.Add(new XAttribute("team-name", "BlueShadows"));
card.Add(new XComment("Add a comment at the top of the XML"));
card.Add(new XElement("PublishedDate", "2016-05-15"));

XElement age = new XElement("Slogan","Double Trouble");
card.Add(age);;
XElement prices = new XElement ("Prices");
prices.Add(new XElement("BidPrice", 34.95M));
prices.Add(new XElement("CatalogPrice", 5.99M));
card.Add (prices);
prices.Add(new XComment("Another comment in the prices element"));
card.Dump();