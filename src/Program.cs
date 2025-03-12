var uuid = Guid.CreateVersion7();
await Console.Out.WriteAsync($"{uuid.ToString()}");