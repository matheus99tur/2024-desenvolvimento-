// See https://aka.ms/new-console-template for more information


// int[] vetor = new int[1000];
// // Gerar valores aleatórios e preencher o vetor
// Random random = new Random();
// for (int i = 0; i < vetor.Length; i++)
// {
//     vetor[i] = random.Next(0, 1001); // Gera números entre 0 e 9999
// }

// // Função para implementar o Bubble Sort
// void BubbleSort(int[] array)
// {
//     int n = array.Length;
//     for (int i = 0; i < n - 1; i++)
//     {
//         for (int j = 0; j < n - i - 1; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//                 // Trocar elementos adjacentes
//                 int temp = array[j];
//                 array[j] = array[j + 1];
//                 array[j + 1] = temp;
//             }
//         }
//     }
// }

// // Ordenar o vetor
// BubbleSort(vetor);

// // Exibir o vetor ordenado
// for (int i = 0; i < vetor.Length; i++)
// {
//     Console.WriteLine(vetor[i]);
// }


/*

bool troca = false;

do
{
    for(int = i; i < vetor.Length -1; i++ )
}
    if(vetor[i] > vetor [i + 1])
{
    int aux = vetor[i];
    vetor[i] = vetor [i + 1];
    vetor [i + 1] = aux;
    troca = true;
  }
 }
}while (troca == true);

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}

*/



int[] vetor = { 5, 3, 8 };
Array.Sort(vetor);

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}
