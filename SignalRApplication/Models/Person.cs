using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRApplication.Models;

public enum Status
{
    Pending,
    Active,
    Passive,
    Deleted
}
public class Person
{
    public Person(string firstName, string lastName, string phone, string? mail, Status? status, string imageURL)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Mail = mail;
        Status = status;
        CreatedDate = DateTime.Now;
        ImageURL = imageURL;
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Mail { get; set; }
    public Status? Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? ImageURL { get; set; }
    [NotMapped]
    public string FullName { get => $"{this.FirstName} {this.LastName}"; }
}
