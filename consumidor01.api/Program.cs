// See https://aka.ms/new-console-template for more information
using consumidor01.api;
using Flurl;
using Flurl.Http;




string url = "https://localhost:7130/";

#region "Objetos"
Item item1 = new Item();
item1.Id = 1;
item1.Nome = "Pagar a conta";
item1.Finalizado = true;

Item item2 = new Item();

item2.Id = 2;
item2.Nome = "Lavara louça";
item2.Finalizado = true;
#endregion


#region POST E LISTAR

string endpoint = url + "api/TarefaItems";

//Flurl 


Console.WriteLine("Vamos Incluir");

// Gerar tarefa post(incluir).
await endpoint.PostJsonAsync(item1);
await endpoint.PostJsonAsync(item2);


//Listar tarefas get (listar)
IEnumerable<Item> listatarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (var item in listatarefas)
{
    Console.WriteLine($"a tarefa {item.Nome} está finalizada: {item.Finalizado}");
}

Console.WriteLine("Vamos alterar");
#endregion

#region PUT e listar
//Alterar 
Console.WriteLine("Digite um id");
int id = Convert.ToInt32(Console.ReadLine());

string endpointalterar = url + $"api/TarefaItems/{id}";

Item item3 = new Item();
item1.Id = 1;
item1.Nome = "Alterar id 1";
item1.Finalizado = false;

await endpointalterar.PutJsonAsync(item3);


//Ler lista 
listatarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (var item in listatarefas)
{
    Console.WriteLine($"a tarefa {item.Nome} está finalizada: {item.Finalizado}");
}


#endregion


//Deletar
Console.WriteLine("Digite um Id para deleção");
//int iddelete = 

//Ler lista 
listatarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (var item in listatarefas)
{
    Console.WriteLine($"a tarefa {item.Nome} está finalizada: {item.Finalizado}");
}



Console.WriteLine("Aperta qualquer tecla para finalizar a aplicação");
Console.Read();