﻿namespace Pluralsight.CShPlaybook.MethodsProps;

public class CookieCustomer
{
	public int Id { get; } // must be > 0

	public string Name { get; } // must contain something

	public string? Notes { get; set; }

	public char NameFirstChar => Name[0];

	public CookieCustomer(int id, string name, string? notes=null)
	{
		ValidateName(name, nameof(name));

		if (id < 0)
			throw BuildInvalidIdException(id, nameof(id));

        Id = id;
		Name = name;
		Notes = notes;
	}

	private ArgumentException BuildInvalidIdException(int value, string paramName)
		=>  new ArgumentException($"Customer ID must be > 0. Actual value was: {value}", paramName);

	public void ValidateName(string value, string paramName)
	{
		if (string.IsNullOrWhiteSpace(value))
        			throw new ArgumentException("Customer name cannot be null or whitespace",paramName);
	}

	public override string ToString() => $"Customer Id={Id}, Name={Name}";


}