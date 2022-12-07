
if (powG>resultMax)
{
    int resultMax=powF;
    int resultMin=powG;
}
int[] result=new int[resultMax];
for (int i=0; i<resultMin; i++)
{
    result[i]=f[i]-g[i];
}
for (int i=resultMin; i<resultMax; i++)
{
    if (resultMax=powG) result[i]=g[i]*(-1);
    else result[i]=f[i];
}