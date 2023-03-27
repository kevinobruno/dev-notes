# Imperative Commands

### Get commands

```sh
kubectl get pods
```

```sh
kubectl get deployments
```

```sh
kubectl get services
```

```sh
kubectl get certificates
```

### Create a secret

```sh
kubectl create secret generic mysecret --from-literal SOME_SECRET_VARIABLE=some-secret-value
```
