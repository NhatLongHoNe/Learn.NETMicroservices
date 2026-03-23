# run docker file
# docker build -t nhatne/platformservice . : build a image
# docker build -t nhatne/commandservice .
docker build -t <username>/platformservice .

# docker run -p 8080:8080 -d nhatne/platformservice : run a container
# docker run -p 6000:8080 -d nhatne/commandservice
docker run -p 8080:8080 -d <username>/platformservice

# docker ps: list all running containers
docker ps

# docker stop <container_id> : stop a container
docker stop <container_id>

# docker rm <container_id> : remove a container
docker rm <container_id>

# docker start <container_id> : start a container
docker start <container_id>

# docker push nhatne/platformservice : push a image to docker hub
# docker push nhatne/commandservice
docker push <username>/platformservice

--------------------------------
# Migration
dotnet ef migrations add InitialCreate --project PlatformService.csproj --startup-project PlatformService.csproj
dotnet ef database update --project PlatformService.csproj --startup-project PlatformService.csproj