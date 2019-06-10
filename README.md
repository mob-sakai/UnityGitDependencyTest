UnityGitDependencyTest
===

## How to test

* Test whether the dependency is resolved correctly when installing/uninstalling `com.coffee.package-a` and `com.coffee.package-b` packages.

#### 1. Auto package resolving

1. Clone this repo and switch to `test` branch.
2. Remove `Library` directory.
3. Open the project on Unity editor.
4. When `Unity Package Manager Error window` is opens, click `Continue`.  
<img width="217" alt="mob-sakai___UnityGitDependencyTest" src="https://user-images.githubusercontent.com/12690315/66263243-35c6c400-e82a-11e9-9373-f61cb4c0b0ed.png">

5. Git url dependencies are resolved property.
```
★★ Installed Packages:
  -> com.coffee.package-a: 1.0.3
  -> com.coffee.package-b: 1.0.1
  -> com.coffee.package-c: 2.0.1
  -> com.coffee.package-x: 2.0.3
  -> com.unity.ads: 3.1.1
```


#### 2. Edit manifest.json while opening Unity (Remove a package)

1. Remove `com.coffee.package-a` in `Packages/manifest.json`
1. Back to Unity editor.
1. Git url dependencies are resolved property.
```
★★ Installed Packages:
  -> com.coffee.package-b: 1.0.1
  -> com.coffee.package-c: 2.0.1
  -> com.coffee.package-x: 2.0.3
  -> com.unity.ads: 3.1.1
```


#### 3. Edit manifest.json while opening Unity (Remove all packages)

1. Remove `com.coffee.package-b` in `Packages/manifest.json`
1. Back to Unity editor.
1. Git url dependencies are resolved property.
```
★★ Installed Packages:
```


#### 4. Edit manifest.json while opening Unity (Add a package)

1. Add `com.coffee.package-a` in `Packages/manifest.json`
1. Back to Unity editor.
1. Git url dependencies are resolved property.
```
★★ Installed Packages:
  -> com.coffee.package-a: 1.0.3
  -> com.coffee.package-x: 2.0.2
  -> com.unity.ads: 3.0.3
```


#### 5. Edit manifest.json while closing Unity (Add a package)

1. Close Unity editor.
1. Add `com.coffee.package-b` in `Packages/manifest.json`
1. Open the project on Unity editor.
1. Git url dependencies are resolved property. **The result is same as step 1.**
```
★★ Installed Packages:
  -> com.coffee.package-a: 1.0.3
  -> com.coffee.package-b: 1.0.1
  -> com.coffee.package-c: 2.0.1
  -> com.coffee.package-x: 2.0.3
  -> com.unity.ads: 3.1.1
```


#### 6. Edit manifest.json while closing Unity (Remove a package)

1. Close Unity editor.
1. Remove `com.coffee.package-a` in `Packages/manifest.json`
1. Open the project on Unity editor.
1. Git url dependencies are resolved property. **The result is same as step 2.**
```
★★ Installed Packages:
  -> com.coffee.package-b: 1.0.1
  -> com.coffee.package-c: 2.0.1
  -> com.coffee.package-x: 2.0.3
  -> com.unity.ads: 3.1.1
```


#### 7. Edit manifest.json while closing Unity (Remove all packages)

1. Close Unity editor.
1. Remove `com.coffee.package-b` in `Packages/manifest.json`
1. Open the project on Unity editor.
1. Git url dependencies are resolved property. **The result is same as step 3.**
```
★★ Installed Packages:
```
