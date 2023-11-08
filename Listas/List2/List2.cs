string[] strings = {"Alo", "lool", "As", "mem", "zo", "los", "coapo"};


StringComparer ordem = StringComparer.CurrentCultureIgnoreCase;

Array.Sort(strings, ordem);


for (int i = 6; i >= 0; i--)
{
    Console.WriteLine(strings[i]);
}
