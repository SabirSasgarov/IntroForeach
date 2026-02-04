using System.Collections.Generic;
using System.Security.Cryptography;

internal class Program
{
	private static void Main(string[] args)
	{
		#region region1
		//int[] numbers = [5,4,8,7];
		//foreach (int number in numbers){
		//	int fac = 1;
		//	for (int j = 2; j <= number; j++)
		//		fac *= j;
		//	Console.Write($"{fac} ");
		//}
		#endregion

		#region region2
		//int[] numbers = [5, 4, 8, 7];
		//int min = numbers[0];
		//foreach (int number in numbers){
		//	if (min > number)
		//		min = number;
		//}
		//foreach (int number in numbers){
		//	if (min == number)
		//		continue;
		//	Console.Write($"{number} ");
		//}
		#endregion

		#region region3
		//string word = "kertenkele";
		//char letter = ' ';
		//int count;
		//foreach(char c in word)
		//{
		//	count = 0;
		//	letter = c;
		//	foreach (char ch in word)
		//	{
		//		if (letter == ch)
		//			count++;
		//	}
		//	if (count == 1)
		//		break;
		//}
		//Console.WriteLine(letter);
		#endregion

		#region region4
		//int n = int.Parse(Console.ReadLine());
		//int m = int.Parse(Console.ReadLine());
		//int lastn;
		//for (int i = n; i < m; i++)
		//{
		//	int number = i;
		//	string newNumber ="";
		//	while (number > 0)
		//	{
		//		lastn = number % 10;
		//		number /= 10;
		//		newNumber += lastn;
		//	}
		//	if (i == Convert.ToInt32(newNumber))
		//		Console.WriteLine(i);
		//}
			#endregion

			#region region5
			//string word = "kertenkele";
			//char letter = ' ';
			//int count = default;
			//int newCount;
			//foreach (char c in word)
			//{
			//	newCount = 0;
			//	foreach (char ch in word)
			//	{
			//		if (c == ch)
			//			newCount++;
			//	}

			//	if (newCount > count)
			//	{
			//		letter = c;
			//		count = newCount;
			//	}
			//}
			//Console.WriteLine($"{letter} {count} defe tekrarlanib.");
			#endregion

			#region region6
			//string sent = "salam necesen sagol";
			//foreach (char s in sent)
			//{
			//	if(s!=' ')
			//		Console.Write(s);
			//}
			#endregion

			#region region7
			//string sent = "salam necesen sagol";
			//char letter = char.Parse(Console.ReadLine());
			//int count = default;
			//foreach (char s in sent)
			//{
			//	if (letter == s)
			//		count++;
			//}
			//Console.WriteLine(count);
			#endregion

			#region region8
			//string sent = "      salam    necesen sagol       ";
			//int count = default;
			//foreach (char s in sent)
			//{
			//	if (s == ' ' && count==0)
			//		continue;
			//	count++;
			//	Console.Write(s);
			//}
			#endregion

			#region region9
			//Console.WriteLine("Zehmet olmasa yerine yetirmek istediyiniz emeliyyati daxil edin:(-,+,/,*)");
			//char emel = char.Parse(Console.ReadLine());
			//while (emel != '*' && emel != '-' && emel != '+' && emel != '/')
			//{
			//	Console.WriteLine("\aZehmet olmasa emeli duzgun daxil edin!(-,+,/,*)");
			//	emel = char.Parse(Console.ReadLine());
			//}
			//Console.WriteLine("Zehmet olmasa ilk ededi daxil edin:");
			//int eded1 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Zehmet olmasa ikinci ededi daxil edin:");
			//int eded2 = int.Parse(Console.ReadLine());
			//switch (emel)
			//{
			//	case '+':
			//		Console.WriteLine($"Ededlerin cemi {(eded1 + eded2)} edir.");
			//		break;
			//	case '-':
			//		Console.WriteLine($"Ededlerin ferqi {(eded1 - eded2)} edir.");
			//		break;
			//	case '*':
			//		Console.WriteLine($"Ededlerin hasili {(eded1 * eded2)} edir.");
			//		break;
			//	case '/':
			//		Console.WriteLine($"Ededleri boldukde {(eded1 / eded2)} edir.");
			//		break;
			//}
			#endregion

			#region region10
			//string sent = "salam necesen sAgol";
			//int count = default;
			//foreach (char s in sent)
			//{
			//	if (s == 'A')
			//		count++;
			//}
			//if (count == 0)
			//	Console.WriteLine("A tapilmadi.");
			//else
			//	Console.WriteLine("A tapildi.");
			#endregion

			#region region11
			//string sent = "salam necesen sAgol";
			//int count = default;
			//foreach (char s in sent)
			//{
			//	if (s == 'A')
			//		count++;
			//}
			//if(count==0)
			//	Console.WriteLine("A tapilmadi.");
			//else
			//	Console.WriteLine($"{count} defe A tapildi.");
			#endregion

			#region region12
			//Console.WriteLine("Musbet bir cut eded daxil edin:");
			//int eded = int.Parse(Console.ReadLine());
			//while(eded%2!=0 || eded < 0)
			//{
			//	if(eded % 2 != 0 && eded < 0)
			//	{
			//		Console.WriteLine("Eded hem tekdir, hem de menfidir! Yeniden cehd edin: ");
			//		eded = int.Parse(Console.ReadLine());
			//	}
			//	else if (eded % 2 != 0)
			//	{
			//		Console.WriteLine("Eded tekdir! Yeniden cehd edin: ");
			//		eded = int.Parse(Console.ReadLine());
			//	}
			//	else
			//	{
			//		Console.WriteLine("Eded menfidir! Yeniden cehd edin: ");
			//		eded = int.Parse(Console.ReadLine());
			//	}
			//}
			//Console.WriteLine($"Ededin kvadrati: {(eded*eded)}");
			#endregion

			#region region13
			//Console.WriteLine("Tehsil novunu daxil edin: (programming, system, design)");
			//string tehsilNovu = Console.ReadLine();
			//switch (tehsilNovu)
			//{
			//	case "programming":
			//		Console.WriteLine($"{tehsilNovu}: 400 saat.");
			//		break;
			//	case "system":
			//		Console.WriteLine($"{tehsilNovu}: 200 saat.");
			//		break;
			//	case "design":
			//		Console.WriteLine($"{tehsilNovu}: 250 saat.");
			//		break;
			//	default:
			//		Console.WriteLine("Tehsil novu yanlisdir.");
			//		break;
			//}
			#endregion

	}
}