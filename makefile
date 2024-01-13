default:
	make start
	make build
	make stop

start:
	docker-compose up -d
	@echo "✔  Server disponivel na porta: http://localhost:8080/"

build:
	docker compose watch

stop:
	docker-compose -f compose.yaml stop 
	