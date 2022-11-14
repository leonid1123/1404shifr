//1. спросить у пользователя слово - 1 шт, на кирилице без пробелов и знаков припенаний
//2. зашифровать
//3. напечатать исходное слово и зашифрованное
Console.WriteLine("Пора шифровать по методу сдвига");
string userInputText = "";
string userInputNumber = "";
int sdvig = 0;
do {
    Console.WriteLine("Введите слово и нажмите ENTER");
    userInputText = Console.ReadLine();
} while (userInputText.Length < 1);
do {
    Console.WriteLine("Введите сдвиг в виде целого числа и нажмите ENTER");
    userInputNumber = Console.ReadLine();
} while (!int.TryParse(userInputNumber, out sdvig));
Console.WriteLine("Текст для шифрования:{0}",userInputText);
Console.WriteLine("Сдвиг шифра:{0}",sdvig);
string abc = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
