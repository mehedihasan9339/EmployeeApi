## Docker Commands with Descriptions (Updated)

Here's an updated breakdown of Docker commands, including the new `docker-compose` and individual container management commands, formatted for easy note-taking:

**Docker Compose:**

*   `docker-compose down`: Stops and removes containers, networks, volumes, and images created by `docker-compose up`.
*   `docker-compose up --build -d`: Builds or rebuilds images, then starts containers in detached mode.
    *   `--build`: Forces a rebuild of images if there are changes in the Dockerfile or context.
    *   `-d`: Detached mode (runs containers in the background).

**Individual Container Management:**

*   `docker stop {container-name}`: Stops a running container. Replace `{container-name}` with the actual container name.
*   `docker rm {container-name}`: Removes a stopped container. Replace `{container-name}` with the actual container name.
*   `docker run -d -p 5000:8080 --name {container-name} {username}/{repo-name}:latest`: Runs a container in detached mode, mapping port 5000 on the host to port 8080 in the container.
    *   `-d`: Detached mode.
    *   `-p 5000:8080`: Port mapping (host:container).
    *   `--name {container-name}`: Assigns a name to the container.
    *   `{username}/{repo-name}:latest`: Specifies the image to run. Replace placeholders with your actual values.

**Building and Running Your Own Image (Previous Commands):**

*   `docker stop employee-api-container`: Stops a running container named `employee-api-container`.
*   `docker rm employee-api-container`: Removes a stopped container named `employee-api-container`.
*   `docker build -t mehedihasan9339/my-aspnetcore-image:latest .`: Builds a Docker image.
    *   `-t`: Tags the image.
    *   `.`: Build context (current directory).
*   `docker run -d -p 32771:8080 -p 32770:8081 --name employee-api-container mehedihasan9339/my-aspnetcore-image:latest`: Runs a container in detached mode, mapping ports.
*   `http://localhost:32771/swagger`: Accesses Swagger UI.

**Pulling, Saving, and Loading an Image (Previous Commands):**

*   `docker pull devopusbd/my-aspnetcore-image:latest`: Downloads an image.
*   `docker save -o my-aspnetcore-image.tar devopusbd/my-aspnetcore-image:latest`: Saves an image to a tar archive.
*   `docker load -i my-aspnetcore-image.tar`: Loads an image from a tar archive.
*   `docker run devopusbd/my-aspnetcore-image:latest`: Runs a container from the loaded image.

**Login and Logout (Previous Commands):**

*   `docker logout`: Logs out from the Docker registry.
*   `docker login`: Logs in to the Docker registry.

**Concise Table Format (Updated):**

| Command                                                                                    | Description                                                                                                                                                                                                                                                                                                                      |
| :----------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `docker-compose down`                                                                    | Stops and removes containers, networks, volumes, and images created by `docker-compose`.                                                                                                                                                                                                                                        |
| `docker-compose up --build -d`                                                            | Builds or rebuilds images and starts containers in detached mode. `--build` forces rebuild. `-d` runs in detached mode.                                                                                                                                                                                                          |
| `docker stop {container-name}`                                                            | Stops a running container. Replace `{container-name}`.                                                                                                                                                                                                                                                                         |
| `docker rm {container-name}`                                                              | Removes a stopped container. Replace `{container-name}`.                                                                                                                                                                                                                                                                        |
| `docker run -d -p <host_port>:<container_port> --name <container_name> <username>/<repo-name>:<tag>` | Runs a container in detached mode, mapping ports and assigning a name. Replace placeholders.                                                                                                                                                                                                                                                                                                                      |
| `docker build -t <image_name>:<tag> .`                                                       | Builds a Docker image. `-t` tags the image.                                                                                                                                                                                                                                                                                        |
| `docker run -d -p <host_port>:<container_port> --name <container_name> <image_name>:<tag>`     | Runs a container, mapping ports and assigning a name.                                                                                                                                                                                                                                                                         |
| `docker pull <image_name>:<tag>`                                                           | Downloads an image.                                                                                                                                                                                                                                                                                                           |
| `docker save -o <archive_name>.tar <image_name>:<tag>`                                      | Saves an image to a tar archive.                                                                                                                                                                                                                                                                                               |
| `docker load -i <archive_name>.tar`                                                         | Loads an image from a tar archive.                                                                                                                                                                                                                                                                                            |
| `docker logout`                                                                            | Logs out from the Docker registry.                                                                                                                                                                                                                                                                                              |
| `docker login`                                                                             | Logs in to the Docker registry.                                                                                                                                                                                                                                                                                                 |

This updated version includes the `docker-compose` commands and provides more clarity on placeholder usage. It should be even more helpful for your notes.
