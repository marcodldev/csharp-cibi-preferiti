//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



string[] cibipreferiti = { "Lasagne", "Pollo", "Cheesecake", "PatateFritte", "Sushi" };



Console.WriteLine("La lista contiene" + " " + cibipreferiti.Length + " " + "cibi:");


for (int i = 0; i < cibipreferiti.Length; i++)
{
    Console.WriteLine(cibipreferiti[i] + " " + (i+1) );
}


Console.WriteLine("Al primo posto abbiamo:" + " " + cibipreferiti[0]);

Console.WriteLine("In fondo alla classifica abbiamo:" + " " + cibipreferiti[cibipreferiti.Length-1]);

Console.WriteLine("In mezzo alla classifica abbiamo:" + " " + cibipreferiti[(cibipreferiti.Length - 1) /2]);

