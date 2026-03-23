# Go to K8S directory
- cd K8S

# 1. check kubectl version
- kubectl version

# 2. kubectl apply -f platforms-depl.yaml : apply the deployment
- kubectl apply -f platforms-depl.yaml
- kubectl apply -f platforms-np-srv.yaml
- kubectl apply -f commands-depl.yaml
- kubectl apply -f ingress-srv.yaml
- kubectl apply -f local-pvc.yaml
- kubectl apply -f mssql-plat-depl.yaml

# 3. check deployments : check the deployment
- kubectl get deployments

# 4. check pods
- kubectl get pods

# 5. delete deployment
- kubectl delete deployment platforms-depl
- kubectl delete service platformnpservice-srv
- kubectl delete deployment mssql-depl
- kubectl delete service mssql-clusterip-srv
- kubectl delete service mssql-loadbalancer

# 6. check services
- kubectl get services
- kubectl get services --namespace=ingress-nginx
# 7. rollout restart
- kubectl rollout restart deployment platforms-depl

# 8. install ingress-nginx
- kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.15.0/deploy/static/provider/cloud/deploy.yaml

# 9. check namespace
- kubectl get namespace

# 10. check ingress-nginx
- kubectl get pods --namespace=ingress-nginx

# 11. check storageclass
- kubectl get storageclass

# 12. check pvc
- kubectl get pvc

# 12.1 delete pvc
- kubectl delete pvc msssql-claim

# 13. create secret
- kubectl create secret generic mssql-secret --from-literal=SA_PASSWORD='pa55w0rd!'
- kubectl create secret generic mssql --from-literal=SA_PASSWORD="YourStrong@Passw0rd"

# 14. check secret
- kubectl get secret