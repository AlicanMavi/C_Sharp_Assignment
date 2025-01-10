using Business.Dtos;
using Business.Factories;
using Business.Models;

namespace Test.Factories;

public class UserFactory_tests
{
    [Fact]
    public void Create_ShouldReturnUserRegistrationForm()
    {
        // Act
        var result = UserFactory.Create();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<UserRegistrationForm>(result);
    }


    [Fact]
    public void Create_ShouldReturnUser_WhenUserRegistrationFormIsProvided()
    {
        // arrange
        var userRegistrationForm = new UserRegistrationForm()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "John.doe@domain.com"
        };

        // Act
        var result = UserFactory.Create(userRegistrationForm);



        //Assert
        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Equal(userRegistrationForm.FirstName, result.FirstName);
        Assert.Equal(userRegistrationForm.LastName, result.LastName);
        Assert.Equal(userRegistrationForm.Email, result.Email);
    }


}
