# Go to K8S directory
- cd K8S

# 1. check kubectl version
- kubectl version

# 2. kubectl apply -f platforms-depl.yaml : apply the deployment
- kubectl apply -f platforms-depl.yaml
- kubectl apply -f platforms-np-srv.yaml
- kubectl apply -f commands-depl.yaml
- kubectl apply -f ingress-srv.yaml

# 3. check deployments : check the deployment
- kubectl get deployments

# 4. check pods
- kubectl get pods

# 5. delete deployment
- kubectl delete deployment platforms-depl
- kubectl delete service platformnpservice-srv

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


# check k8s cluster info
- kubectl cluster-info


# check nodes
- kubectl get nodes



# check events
- kubectl get events

# check configmaps
- kubectl get configmaps

# check secrets
- kubectl get secrets

