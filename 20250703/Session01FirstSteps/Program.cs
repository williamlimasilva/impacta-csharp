string name = "John";
DateTime birthDate = new DateTime(1982, 6, 15); // exemplo de data de nascimento
DateTime today = DateTime.Today;
int age = today.Year - birthDate.Year;
if (birthDate > today.AddYears(-age)) age--;
double height = 1.75;
bool isEmployed = true;

Console.WriteLine($"Name: {name}, tenho {age} anos, {height} de altura");