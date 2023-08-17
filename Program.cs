using Arquivos.Views; //Ele vai comunicar com o view

int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para Atendimento");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Atendimento");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Veterinario");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
        Console.WriteLine("OPÇÃO ATENDIMENTO");
        AtendimentoView atendimentoView = new AtendimentoView();
        break;
        

        case 2 :
        Console.WriteLine("OPÇÃO ANIMAIS");
        AnimalView animalView = new AnimalView();
        break;


        case 3 :
        Console.WriteLine("OPÇÃO VETERINARIO");
        VeterinarioView veterinarioView = new VeterinarioView();
        break;
    }
}
while( option > 0); //enquanto option for maior que zero