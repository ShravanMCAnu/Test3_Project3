// See https://aka.ms/new-console-template for more information

string sentence = "A quick brown fox jumps over the lazy dog";
Console.WriteLine("(a) Index of fox: " + sentence.IndexOf("fox"));

string sentence1 = sentence.Substring(37, 4);
string sentence2="";
Console.Write("(b) The reverse string of :" + sentence1 + " is ");
for (int i = sentence1.Length - 1; i > 0; i--)
{
    Console.Write(sentence2 = sentence1.Substring(i, 1));

}
string substring1 = sentence.Substring(14, 3);
string substring2 = sentence.Substring(22, 19);
Console.WriteLine("\n(c) " + substring1 + substring2);
int count = 0;
for (int i = 0; i < sentence.Length; i++)
{
    if (sentence.Substring(i, 1) == "u")
    {
        count++;
    }

}
Console.WriteLine("(d) \'u\' count in the sentence  is: " + count);
int length = sentence.Length;
Console.WriteLine("(e) Length of the sentence is "+length);
string sentence_Replace = sentence.Replace("a", "1").Replace("e", "1").Replace("i", "1").Replace("o", "1").Replace("u", "1").Replace("A", "1").Replace("E", "1").Replace("I", "1").Replace("O", "1").Replace("U", "1");
Console.WriteLine("(f) Replace of sentence words from A,E,I,O,U with 1:" + sentence_Replace);

















