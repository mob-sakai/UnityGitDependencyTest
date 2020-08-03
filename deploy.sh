#!/bin/bash -e

git subtree split --prefix="Packages/math" --branch math
git subtree split --prefix="Packages/transform-it" --branch transform-it
git subtree split --prefix="Packages/translate-it" --branch translate-it
git subtree split --prefix="Packages/rotate-it" --branch rotate-it

git push origin math
git push origin transform-it
git push origin translate-it
git push origin rotate-it
