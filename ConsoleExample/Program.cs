using ValidationAttribute;

User user = new() { Name = "Ahmet Burak", Surname = "Ağca" };

bool result = ValidationTool.Validate(user);
Console.WriteLine(result ? "Validasyon başarılı." : "Validasyon başarısız! Zorunlu alanlar boş olamaz.");