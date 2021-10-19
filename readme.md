Sample project for a Kubernetes ASP.NET core application with Clean Architecture
 - Dockerfile exposing both HTTP and HTTPS custom ports overwritten default [Kestrel settings](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel?view=aspnetcore-5.0)
 - Helm chart for deployment on Kubernetes cluster
 - Mount HTTPS (TLS/SSL) certificate via volume secret, certificate password as secret and use it with Kestrel
 - Health endpoint for probes - used for warmup process and to determind if process is responsive
 - Graceful shutdown with SIGTERM and SIGKILL - giving the application time to cleanup connections etc.
 - Specify the compute resources needed to run and maximum consumption
 - Execute as unprivileged account
 
 
 # References
 - [Developing a Dockerized Asp.Net Core Application Using Visual Studio Code](https://medium.com/@waelkdouh/developing-a-dockerized-asp-net-core-application-using-visual-studio-code-6ccfc59d6f6)
 - [Helm Chart Development Tips and Tricks](https://github.com/helm/helm/blob/master/docs/charts_tips_and_tricks.md)
 - [Managing ASP.NET Core App Settings on Kubernetes](https://anthonychu.ca/post/aspnet-core-appsettings-secrets-kubernetes/)
 - [Health checks in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-2.2)
 - [Graceful termination in Kubernetes with ASP.NET Core](https://blog.markvincze.com/graceful-termination-in-kubernetes-with-asp-net-core/#comment-4509101865)
 - [Understanding how uid and gid work in Docker containers](https://medium.com/@mccode/understanding-how-uid-and-gid-work-in-docker-containers-c37a01d01cf)
