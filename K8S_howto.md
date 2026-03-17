# Go to K8S directory
- cd K8S

# 1. check kubectl version
- kubectl version

# 2. kubectl apply -f platforms-depl.yaml : apply the deployment
- kubectl apply -f platforms-depl.yaml
- kubectl apply -f platforms-np-srv.yaml
- kubectl apply -f commands-depl.yaml

# 3. check deployments : check the deployment
- kubectl get deployments

# 4. check pods
- kubectl get pods

# 5. delete deployment
- kubectl delete deployment platforms-depl
- kubectl delete service platformnpservice-srv

# 6. check services
- kubectl get services

# 7. rollout restart
- kubectl rollout restart deployment platforms-depl

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

