using Xunit;

namespace UC7.Tests;

public class StudentConverterTests
{
    private readonly StudentConverter _studentConverter = new StudentConverter();

    [Fact]
    public void ConvertStudents_StudentAgeAbove21GradeAbove90_HonorRollIsTrue()
    {
        //Arrange
        var student = new Student
        {
            Age = 25,
            Grade = 95
        };

        var inputList = new List<Student> { student };
        
        //Act
        var resultList = _studentConverter.ConvertStudents(inputList);
        
        //Assert
        Assert.True(resultList[0].HonorRoll);
    }

    [Fact]
    public void ConvertStudents_AgeBelow21GradeAbove90_ExceptionalIsTrue()
    {
        //Arrange
        var student = new Student
        {
            Age = 20,
            Grade = 95
        };

        var inputList = new List<Student> { student };
        
        //Act
        var resultList = _studentConverter.ConvertStudents(inputList);
        
        //Assert
        Assert.True(resultList[0].Exceptional);
    }

    [Fact]
    public void ConvertStudents_GradeBetween71And90_PassedIsTrue()
    {
        //Arrange
        var student = new Student
        {
            Age = 21,
            Grade = 80
        };

        var inputList = new List<Student> { student };
        
        //Act
        var resultList = _studentConverter.ConvertStudents(inputList);
        
        //Assert
        Assert.True(resultList[0].Passed);
    }
            
    [Fact]
    public void ConvertStudents_GradeBelow71_PassedIsFalse()
    {
        //Arrange
        var student = new Student
        {
            Age = 20,
            Grade = 60
        };

        var inputList = new List<Student> { student };
        
        //Act
        var resultList = _studentConverter.ConvertStudents(inputList);
        
        //Assert
        Assert.False(resultList[0].Passed);
    }

    [Fact]
    public void ConvertStudents_EmptyArrayPassed_ReturnsEmptyArray()
    {
        //Arrange
        var inputList = new List<Student>();
        
        //Act
        var resultList = _studentConverter.ConvertStudents(inputList);
        
        //Assert
        Assert.False(resultList.Any());
    }

    [Fact]
    public void ConvertStudents_NullPassed_ThrowsException()
    {
        //Arrange
        List<Student> inputList = null!;
                
        //Act & Assert
        Assert.ThrowsAny<Exception>(() => _studentConverter.ConvertStudents(inputList));
    }
}
