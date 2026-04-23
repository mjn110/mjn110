var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PersonalWebsite>("personalwebsite");

builder.Build().Run();
