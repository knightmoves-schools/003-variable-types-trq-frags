namespace Tests;

using knightmoves;
using Xunit;
using System.Text.RegularExpressions;

public class CommentTest
{
    [Fact]
    public void Should_Define_A_Public_Class_Level_String_Variable_Named_AnimalName()
    {
        var variableTypes = new VariableTypes();

        Assert.True("String".Equals(variableTypes.AnimalName.GetType().Name), "should define a public class level string variable named AnimalName");
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_Character_Variable_Named_GradeLetter()
    {
        var variableTypes = new VariableTypes();

        Assert.True("Char".Equals(variableTypes.GradeLetter.GetType().Name), "should define a public class level string variable named GradeLetter");
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_Whole_Number_Variable_Named_Year()
    {
        var variableTypes = new VariableTypes();

        Assert.True("Int32".Equals(variableTypes.Year.GetType().Name), "should define a public class level whole number variable named Year");
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_Decimal_Number_Variable_Named_Height()
    {
        var variableTypes = new VariableTypes();

        Assert.True("Double".Equals(variableTypes.Height.GetType().Name), "should define a public class level decimal number variable named Height");
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_Boolean_Variable_Named_IsIndoorPet()
    {
        var variableTypes = new VariableTypes();

        Assert.True("Boolean".Equals(variableTypes.IsIndoorPet.GetType().Name), "should define a public class level boolean variable named IsIndoorPet");
    }
}
