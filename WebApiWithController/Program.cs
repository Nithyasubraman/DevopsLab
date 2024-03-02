using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();











//node
//{
//    stage(' 1. Git Checkout'){
//        git 'https://github.com/Nithyasubraman/NithuJenkinsDemo.git'
//    }
//    stage(' 2. Build the Project'){
//    bat 'dotnet build'
//    }
//stage(' 3. Test the Project'){
//    bat 'dotnet test'
//    }
//stage(' 4. Code Quality Test '){
//    bat 'dotnet sonarscanner begin /k:"CICD_Sample" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_ba8b58e9467dc3a058eb7516b37ec29b3a030d56"'
//    }
//stage(' 5. Code Quality Build '){
//    bat 'dotnet build'
//    }
//stage(' 6. Publish Project '){
//    bat 'dotnet sonarscanner end /d:sonar.token="sqp_ba8b58e9467dc3a058eb7516b37ec29b3a030d56"'
//    }
//dir('JenkinsDemo')
//    {
//    stage(' 7. Dockerize Project '){
//        bat 'docker image build --tag myproject .'
//    }
//}
//}


//node
//{
//    stage(' 1. Git Checkout'){
//        git 'https://github.com/Nithyasubraman/NithuJenkinsDemo.git'
//    }
//}







//Inside node --before stage 

//node{

//dir ( <<Folder Path>>)
//{
//  stage('text')
//  {
//          //our commands
//  }
//}

//}


//git init
//git add .
//git status
//git commit -m 'First Commit'
//git remote add origin https://github.com/Nithyasubraman/NithuJenkinsDemo.git
//git push -u origin master











//git add .
//git commit -m 'added dockerfile'
//git push -u origin master




//1...2..3...7...

