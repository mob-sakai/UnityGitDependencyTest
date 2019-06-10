#!/bin/bash -e

git subtree split --prefix="Packages/com.coffee.packageA" --branch package-a
git subtree split --prefix="Packages/com.coffee.packageB" --branch package-b
git subtree split --prefix="Packages/com.coffee.packageC" --branch package-c
git subtree split --prefix="Packages/com.coffee.packageX" --branch package-x
