namespace Factoriel.Test;

public class FactorielTest
{
    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-50)]
    [InlineData(-100)]
    [InlineData(-150)]
    public void Factoriel_Negatif_Not_Exist(int value)
    {
        try
        {
            var result = Factoriel.factoriel(value);
        }
        catch (System.Exception e)
        {  
            Assert.Equal("Le factoriel d'un nombre négatif n'existe pas",e.Message);
        }
    }

    [Theory]
    [InlineData(0,1)]
    [InlineData(1,1)]
    [InlineData(2,2)]
    [InlineData(3,6)]
    [InlineData(4,24)]
    // [InlineData(5,24)]
    public void Factoriel_Positif_Number_Is_Positif_Number(int value,int value2){
        var result = Factoriel.factoriel(value);
        Assert.Equal(value2,result);
    }
}