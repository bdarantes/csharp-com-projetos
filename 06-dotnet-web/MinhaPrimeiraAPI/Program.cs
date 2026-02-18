var builder = WebApplication.CreateBuilder(args);

// --- 1. ÁREA DE SERVIÇOS (Ingredientes) ---
// Adicione isto aqui ANTES do builder.Build()
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Necessário para APIs mínimas
builder.Services.AddSwaggerGen();           // <--- O ERRO ESTAVA FALTANDO AQUI!

var app = builder.Build();

// --- 2. ÁREA DE PIPELINE (Como o bolo é servido) ---

// Configure o HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();    // <--- Deu erro aqui porque não tinha o AddSwaggerGen lá em cima
    app.UseSwaggerUI();  // <--- Cria a tela visual
}

app.UseAuthorization();

app.MapControllers();

app.Run();