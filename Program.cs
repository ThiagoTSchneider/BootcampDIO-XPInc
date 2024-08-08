using BootcampDIO_XPInc.Models;

//pessoaFisica <--> [c]amel[C]ase | Variables is always --> camelCase 
//Special Characthers in Variables is a no no :) only underline --> _
//altura.ToString("0.00")); <-- doubles ignores the unit of the decimal case  | Fix needed in certains cases --> decimal more likely to be used in this cases
//Decimal has to have a [M] in the end
//Methods | Function --> [P]ascal[C]ase

//cannot convert int to string
//must do the conversion manually
//int a = 5;
//string b = a.ToString();
//or use string at the call of the variable

//Logic Operators
//--> NOT (!) | Change the value of the variable --> if True <--> False
bool rained = true;
rained = !rained;

//If True --> False | If False --> True
if (!rained){
    Console.WriteLine("Go Biking");
    Console.WriteLine(rained);
}


//Logic Operators
//--> AND (&&) | Checks if both conditions are true --> if not return false
bool  old = true;
bool  authorization = false;

//if only both of them are true --> Procede 
if (old && authorization){
    Console.WriteLine("Entrada Permitida"); //enter
}
else{
    Console.WriteLine("Entrada Negada"); //do not enter
}


//Logic Operators 
//--> OR (Pipe, || ) | Checks if one of the conditions is true --> 
bool  oldenough = true;
bool  hasAuthorization = false;

//if only validate if one of the conditions is true
if (oldenough || hasAuthorization){
    Console.WriteLine("入れる"); //enter
}
else{
    Console.WriteLine("入れない"); //do not enter
}


Console.WriteLine("Digite uma letra");

//Console.ReadLine(); well it kinda explains itself :p
string letra = Console.ReadLine();
letra = letra.ToLower();


switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}


//&& --> Means if condition is True procede | if produtoCompra is higher than 0 procede
int produtoCompra = 0;
int produtoEmEstoque = 30;
bool possibilidadeVenda = produtoCompra > 0 && produtoEmEstoque >= produtoCompra;


Console.WriteLine($"Possibilidade de realizar Venda:{possibilidadeVenda}");
Console.WriteLine($"Quantidade em Estoque:{produtoEmEstoque}");


//Bool variable if true make the transaction | If not say it's out of stock
//Only 2 possibles states True or False | True = Procede with IF | False = Procede with ELSE
if (produtoCompra == 0){
    Console.WriteLine("Por favor inserir Quantidade de compra");
}
else if (possibilidadeVenda){
    Console.WriteLine("Compra Realizada");
}
else
{
    Console.WriteLine("Produto nao se encontra em Estoque");

}



string asecure = "15-"; // "15-" <-- error | wrong format


// TryParse --> Try  to convert a string to a int | If it is possible, it will convert | if not return 0
int.TryParse(asecure, out int bsecure); // If omitted must specify the type of the variable on the arguments

Console.WriteLine($"{bsecure} Convert");


//Operation Order
double lk = 4 / 2 + 2; // = 4
lk = 4 / (2 + 2);  // = 1


Console.WriteLine($"{lk} Double");


//This is a inplicit conversion
//When you call double m = l; it does a conversion to double

//Inplicit - Conversion
int l = 5;
double m = l;

Type t = m.GetType();

Console.WriteLine($"{m} Inplicit - Conversion");
Console.WriteLine(t);


//In some situations, variable may come in int
//Then Casting is needed

//Cast - Casting
int as1 = 5;
string astring = as1.ToString();


Console.WriteLine($"{astring} Cast - Casting");


//Convert --> Convert treats null differently than Parse | Converts null to 0 <-- Recommended
//Parse --> Parse treats null as an error | Value cannot be null

int ac1 = int.Parse("5");

Type atype = ac1.GetType();

Console.WriteLine(ac1);
Console.WriteLine(atype); //System.Int32


int a = 10;
int b = 20;

int c = a + b;


// c = c + 5; <-- same as c += 5;
// c = c - 5; <-- same as c -= 5;
// c = c * 5; <-- same as c *= 5;
// c = c / 5; <-- same as c /= 5;

c += 5;
c /= 5;
c *= 5;
c -= 5;

Console.WriteLine($"Valor da variável C: {c}");


DateTime dataAtual = DateTime.Now.AddDays(3);

Console.WriteLine(dataAtual.ToString());


string apresentacao = "Olá, seja bem vindo!";
int quantidade = 7;
double altura = 1.90;
decimal preco = 2.10M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Valor da variável quantidade: {quantidade}");
Console.WriteLine($"Valor da variável altura: {altura}");
Console.WriteLine($"Valor da variável preco: {preco}");
Console.WriteLine($"Valor da variável condicao: {condicao}");

PessoaFisica usuarios = new PessoaFisica();

usuarios.Nome = "Luiz";
usuarios.Idade = 25;

usuarios.apresentar();