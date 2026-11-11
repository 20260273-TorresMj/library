using System.ComponentModel.DataAnnotations;

namespace library.Models;

public class Member
{
    public long MemberId { get; set; }

    // 1. Rule: a name of at most 80 characters.
    [StringLength(80, ErrorMessage = "The name can be at most 80 characters.")]
    // 2. Rule: the name is written as Lastname, Firstname.
    [RegularExpression(@"^[A-Za-zÑñ'.-]+, [A-Za-zÑñ'.-]+$", ErrorMessage = "Write the name as Lastname, Firstname.")]
    public string FullName { get; set; } = "";

    // 3. Rule: an email of at most 120 characters.
    [StringLength(120, ErrorMessage = "The email can be at most 120 characters.")]
    // 4. Rule: an email such as ana@ubaguio.edu, when one is given.
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[A-Za-z]{2,}$", ErrorMessage = "Enter an email such as ana@ubaguio.edu.")]
    public string? Email { get; set; }

    public string MemberType { get; set; } = "";

    // Task 11 - Snippet 11.1
    public long OpenLoans { get; set; } // filled only by the member list; never saved
}