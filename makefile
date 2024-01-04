default:
	make start
	make build

start:
	docker-compose -f compose.yaml start
	dotnet run

build:
	docker compose up --build