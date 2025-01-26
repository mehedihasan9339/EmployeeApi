# Docker Commands for Managing Application

This document contains the basic Docker commands to manage the lifecycle of your application container.

## 1. **Bring Down Docker Containers**

To stop and remove the containers, networks, and volumes defined in your `docker-compose.yml` file:

```bash
docker-compose down
```

This will stop the containers and remove them.

---

## 2. **Build and Run Docker Containers**

To build and start the containers in the background:

```bash
docker-compose up --build -d
```

- `--build` forces the rebuild of images.
- `-d` runs the containers in detached mode (background).

---

## 3. **Stop a Running Docker Container**

To stop a running container by its name or ID:

```bash
docker stop {container-name}
```

Replace `{container-name}` with the name of your container (e.g., `EmployeeApi`).

---

## 4. **Delete a Docker Container**

To remove a stopped container:

```bash
docker rm {container-name}
```

Replace `{container-name}` with the name of your container (e.g., `EmployeeApi`).

---

## 5. **Run a Docker Container**

To run a container from an image with port mapping:

```bash
docker run -d -p 5000:8080 --name {container-name} {username}/{repo-name}:latest
```

- `-d` runs the container in detached mode.
- `-p 5000:8080` maps port 8080 inside the container to port 5000 on your local machine.
- `{container-name}` is the desired name for your container (e.g., `EmployeeApi`).
- `{username}/{repo-name}:latest` is the image you want to use (e.g., `mehedihasan9339/my-aspnetcore-image:latest`).

---

## Notes

- Ensure your `docker-compose.yml` file is in the correct directory when running the `docker-compose` commands.
- Always replace `{container-name}`, `{username}`, and `{repo-name}` with the actual container name, DockerHub username, and repository name, respectively.

---
