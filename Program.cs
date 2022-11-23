//1. спросить у пользователя слово - 1 шт, на кирилице без пробелов и знаков припенаний
//2. зашифровать
//3. напечатать исходное слово и зашифрованное
Console.WriteLine("Пора шифровать по методу сдвига");
string userInputText = "";
string userInputNumber = "";
int sdvig = 0;
do
{
    Console.WriteLine("Введите слово и нажмите ENTER");
    userInputText = Console.ReadLine().ToLower();
} while (userInputText.Length < 1);
string[] userInputWords = userInputText.Split(' ');
do
{
    Console.WriteLine("Введите сдвиг в виде целого числа и нажмите ENTER");
    userInputNumber = Console.ReadLine();
} while (!int.TryParse(userInputNumber, out sdvig));
Console.WriteLine("Текст для шифрования:{0}", userInputText);
Console.WriteLine("Сдвиг шифра:{0}", sdvig);
string abc = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
string abcShifr = "";
for (int i = 0; i < abc.Length; i++)
{
    int x = i + sdvig;
    if (x > 32)
    {
        x -= 33;
    }
    abcShifr += abc[x];
}
Console.WriteLine("Шифрованный алфавит:{0}", abcShifr);
string shifr = "";
for(int i = 0; i < userInputText.Length; i++)
{
    shifr += abcShifr[abc.IndexOf(userInputText[i])];
}
Console.WriteLine("Зашифрованное слово:{0}",shifr);
//решить проблемы:большие буквы, пробел, знаки припенания, латиница
//сделать запись в БД
//метод для шифрования слова. 
string CodeWord(string _abcShifr, string _word, int _sdvig){

}