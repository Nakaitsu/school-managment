using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Infrastructure
{
  public class MinValueAttribute : ValidationAttribute
  {
    private readonly double _minValue;
    
    public MinValueAttribute(double value)
    {
      _minValue = value;
      ErrorMessage = "The value must be greater than " + _minValue;
    }

    public MinValueAttribute(int value)
    {
      _minValue = value;
      ErrorMessage = "The value must be greater than " + _minValue;
    }

    public override bool IsValid(object? value)
    {
      return Convert.ToDouble(value) >= _minValue;
    }
  }

  public class MaxValueAttribute : ValidationAttribute
  {
    private readonly double _maxValue;
    
    public MaxValueAttribute(double value)
    {
      _maxValue = value;
      ErrorMessage = "The value must be less than " + _maxValue;
    }

    public MaxValueAttribute(int value)
    {
      _maxValue = value;
      ErrorMessage = "The value must be less than " + _maxValue;
    }

    public override bool IsValid(object? value)
    {
      return Convert.ToDouble(value) <= _maxValue;
    }
  }

  public class ValidateDate : ValidationAttribute
  {
    protected override ValidationResult IsValid(object date, ValidationContext validationContext)
    {
      return ((DateTime)date <= DateTime.Now && (DateTime)date >= DateTime.Parse("01-01-1950"))
        ? ValidationResult.Success 
        : new ValidationResult("Invalid date range");
    }
  }
}