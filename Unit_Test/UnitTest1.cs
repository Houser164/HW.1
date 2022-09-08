namespace Unit_Test;

public class UnitTest1
{
    [Fact]
    public void Check_money()
    {
    double AAA = Program.Check_money("888");
    Assert.IsType<double>(AAA);
    }

    [Fact]     public void ABC()     {                
    double[] Ans = { 5, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 };                
    double[] Num = Program.ABC(5120.25);                
    Assert.Equal(Ans, Num);     
    } 
}    
