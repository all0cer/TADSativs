#include <stdio.h>
 
int main(){
    int n, i, acima, abaixo;
    double media;
        scanf("%d", &n);
    long quant[n];
    for(i=0; i<n; i++){
        scanf("%d", &quant[i]);
        media+=quant[i];
    }
    media=media/n;
    for(i=0; i<n; i++){
        if(quant[i]>=media){acima++;}
        if(quant[i]<media){abaixo++;}
    }
    printf("%.1f\n%d\n%d\n", media, abaixo, acima);
    return 0;
}