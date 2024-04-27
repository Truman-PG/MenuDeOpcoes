//Variáveis das mensagens correspondentes
string opcao1 = "Bom Dia, tenha um ótimo dia!!!";
string opcao2 = "Boa Tarde, pegue sua bebida preferida e aproveite essa metade do dia!!!";
string opcao3 = "Boa Noite, ajeite a cama, prepare o corpo para descansar!!!";

//Cria a variável para a resposta da pessoa
string resposta;

//Começa o laço
do
{
    //Mostra as opções para a pessoa escolher
    Console.WriteLine("Escolha alguma das opções abaixo.");
    Console.WriteLine("1 - Mensagem de Bom Dia");
    Console.WriteLine("2 - Mensagem de Boa Tarde");
    Console.WriteLine("3 - Mensagem de Boa Noite");
    Console.WriteLine("4 - Sair");

    //A variável "resposta" vai ser denominado pelo o qual a pessoa selecionar
    resposta = Console.ReadLine();

    //Limpa a tela
    Console.Clear();

    if (resposta == "1")
    {
        Console.WriteLine(opcao1);
    }
    else if (resposta == "2")
    {
        Console.WriteLine(opcao2);
    }
    else if (resposta == "3")
    {
        Console.WriteLine(opcao3);
    }
    else
    {
        //Mostra a mensagem caso a pessoa não escolha de acordo com a opção
        Console.WriteLine("Essa opção não existe.");
    }
    Console.ReadKey();
    Console.Clear();
}
//Fecha a execução quando a pessoa digitar "4" para sair
while (resposta != "4");