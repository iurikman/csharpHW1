




string Method(string text, char a, char b) {

    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == a) result = result + $"{b}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string text = "аапппппппппппп";
string ntext = Method(text, 'п', 'П');
Console.WriteLine(ntext);
