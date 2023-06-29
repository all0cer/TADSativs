#include <iostream>

using namespace std;

/*Recebe o tamanho do labirinto(matriz até 20 por 20)
   Recebe qtd de linhas e colunas
   recebe os valores X e Y da célula da matriz*/
int labirinto_bt(int labirinto[20][20],
    int linha, int coluna,
    int x, int y){
    if (x==-1 || y==-1 || x==coluna || y==linha || labirinto[y][x]!=0) //Se for do tamanho da matriz, valores negativos, ou a posição das células for diferente de 0, retorna Falso
        return 0;

    if (x==coluna-1 && y==linha-1) // Se for a ultima célula da matriz, retorna verdadeiro
        return 1;

    labirinto[y][x] = 9; // Marca todas as células que passou com o valor 9
    int ans = 0 ;
    //cada função tentará os 4 caminhos na célula
    ans = labirinto_bt(labirinto, linha, coluna, x, y+1) || //tenta abaixo, caso dê errado, tentará na seguinte
          labirinto_bt(labirinto, linha, coluna, x+1, y) || //tentará á esquerda até que retorne falso nas 4, então vai para a seguinte
          labirinto_bt(labirinto, linha, coluna, x-1, y) || // tentará para baixo até que retorne falso nas 4 então vai para a seguinte
          labirinto_bt(labirinto, linha, coluna, x, y-1); //tentará todas as alternativas, e após isso retornára a célula para 0

    labirinto[y][x] = 0;
    return ans;
}

int main(){
    int linha, coluna, labirinto[20][20];
    scanf("%d %d", &linha, &coluna);
    for (int i=0 ; i<linha ; ++i)
        for (int j=0 ; j<coluna ; ++j)
            scanf("%d",&labirinto[i][j]);

int saida = labirinto_bt(labirinto, linha, coluna, 0,0 );
printf("%d\n",saida);

return 0;
}