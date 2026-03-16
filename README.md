## Tech Stack
| Layer            | Technology           | Why                                        |
|------------------|----------------------|--------------------------------------------|
| UI               | Blazor WASM          | Runs in browser, deploys as static files   |
| Database         | Supabase PostgresSQL | Free, persistent, relational               |
| Auth             | Supabase Auth        | JWT-based, OAuth support                   |
| Frontend Hosting | GitHub Pages         | Already using GitHub for repo              |
| File Storage     | Supabase Storage     | Already using Supabase for other functions |

## Devcontainers

Devcontainers are a quick and easy way to create consistent, isolated 
development environments between different local machines. You can read more 
about development containers and the underlying devcontainer.json spec 
[here](https://containers.dev).

### Devcontainer Setup
In order to utilize the devcontainers in this repository, you'll need to 
have the following:
* .NET dev certificates setup on your local machine. (required)
* GnuPG for signing git commits. (optional for devcontainer, but required 
  for pushing)

To set up .NET dev certificates, do the following:

```
dotnet dev-certs https \
--export-path ~/.aspnet/certs/https-dev-cert.pfx \
--password YOUR_PASSWORD_HERE
```