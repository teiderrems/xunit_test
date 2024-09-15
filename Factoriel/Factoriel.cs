namespace Factoriel;

public class Factoriel
{
    public static int factoriel(int k){
        if (k<0)
        {
            throw new Exception("Le factoriel d'un nombre négatif n'existe pas");
        }
        if (k==0 || k==1)
        {
            return 1;
        }
        return k*factoriel(k-1);
    }
}
