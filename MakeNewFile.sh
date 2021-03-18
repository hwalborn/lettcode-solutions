cp ./Problems/Algorithms/Template.cs ./Problems/Algorithms/$1.cs

touch ./Notes/Algorithms/$1.md

sed -i '' 's/Template/'$1'/g' ./Problems/Algorithms/$1.cs