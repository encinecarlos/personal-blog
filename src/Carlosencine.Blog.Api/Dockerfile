#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Carlosencine.Blog.Api/Carlosencine.Blog.Api.csproj", "Carlosencine.Blog.Api/"]
RUN dotnet restore "Carlosencine.Blog.Api/Carlosencine.Blog.Api.csproj"
COPY . .
WORKDIR "/src/Carlosencine.Blog.Api"
RUN dotnet build "Carlosencine.Blog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Carlosencine.Blog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Carlosencine.Blog.Api.dll"]