# Set the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set the work directory
WORKDIR /app

# Copy the build output
COPY bin/Release/net8.0/publish/ .

# Expose the port
EXPOSE 80

# Set the entry point
ENTRYPOINT ["dotnet", "Shipping.API.dll"]
