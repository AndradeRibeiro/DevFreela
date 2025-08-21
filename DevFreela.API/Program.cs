using DevFreela.Application.Commands.ProjectCommands.CreateProject;
using DevFreela.Application.Commands.ProjectCommands.CreateProjectComment;
using DevFreela.Application.Commands.ProjectCommands.DeleteProject;
using DevFreela.Application.Commands.ProjectCommands.FinishProject;
using DevFreela.Application.Commands.ProjectCommands.StartProject;
using DevFreela.Application.Commands.ProjectCommands.UpdateProject;
using DevFreela.Application.Commands.UserCommands.CreateUser;
using DevFreela.Application.Queries.ProjectQueries.GetAllProjects;
using DevFreela.Application.Queries.ProjectQueries.GetProjectById;
using DevFreela.Application.Queries.SkillQueries.GetAllSkills;
using DevFreela.Application.Queries.UserQueries.GetUserById;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "DevFreela API",
        Version = "v1",
        Description = "API for managing freelancers and projects in .NET 9"
    });
});

builder.Services.AddDbContext<DevFreelaDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMediatR(typeof(CreateProjectCommand).Assembly);
builder.Services.AddMediatR(typeof(CreateProjectCommentCommand).Assembly);
builder.Services.AddMediatR(typeof(UpdateProjectCommand).Assembly);
builder.Services.AddMediatR(typeof(DeleteProjectCommand).Assembly);
builder.Services.AddMediatR(typeof(StartProjectCommand).Assembly);
builder.Services.AddMediatR(typeof(FinishProjectCommand).Assembly);
builder.Services.AddMediatR(typeof(CreateUserCommand).Assembly);
builder.Services.AddMediatR(typeof(GetAllProjectsQuery).Assembly);
builder.Services.AddMediatR(typeof(GetAllSkillsQuery).Assembly);
builder.Services.AddMediatR(typeof(GetProjectByIdQuery).Assembly);
builder.Services.AddMediatR(typeof(GetUserByIdQuery).Assembly);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
