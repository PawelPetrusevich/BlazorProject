#windows VM

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY Blazor.BlazorUI.csproj Blazor.BlazorUI.csproj
RUN dotnet restore Blazor.BlazorUI.csproj
COPY . .
WORKDIR /src
RUN dotnet build "Blazor.BlazorUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blazor.BlazorUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blazor.BlazorUI.dll"]


#linux VM

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
#WORKDIR /src
#COPY Blazor.BlazorUI.csproj Blazor.BlazorUI.csproj
#RUN dotnet restore Blazor.BlazorUI.csproj
#COPY . .
#WORKDIR "/src/Blazor.BlazorUI"
#RUN dotnet build "Blazor.BlazorUI.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Blazor.BlazorUI.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Blazor.BlazorUI.dll"]