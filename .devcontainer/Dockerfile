# This is a development Container.
# DO NOT USE FOR ANYTHING OTHER THAN DEVELOPMENT!

ARG CONTAINER_REPOSITORY_BASE_URL=mcr.microsoft.com
ARG CONTAINER_ASPNET=dotnet/aspnet
ARG CONTAINER_ASPNET_VERSION=10.0
ARG CONTAINER_NETSDK=dotnet/sdk
ARG CONTAINER_NETSDK_VERSION=10.0

FROM ${CONTAINER_REPOSITORY_BASE_URL}/${CONTAINER_NETSDK}:${CONTAINER_NETSDK_VERSION} AS dotnet-with-npm
# Install Angular CLI via npm
RUN apt-get update
RUN apt-get install curl
RUN curl -sL https://deb.nodesource.com/setup_20.x | bash
RUN apt-get -y install nodejs
RUN npm install -g @angular/cli
RUN npm install -g pnpm

FROM dotnet-with-npm AS build
ARG BUILD_CONFIGURATION=Release
ENV CI=true

WORKDIR /src

# Context must be Root Folder
COPY "./src/CRAms" "./CRAms"

ENTRYPOINT ["dotnet", "run", "--project", "/src/CRAms/CRAms.API/CRAms.API.csproj"]
