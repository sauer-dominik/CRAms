# Dockerfile

Run following command (from root Directory) to build the docker container:
`docker buildx build -t crams -f .devcontainer/Dockerfile .`

Run following command to run the docker container:
`docker run -p 53052:53052 crams`
