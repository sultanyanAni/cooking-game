using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCookServe
{
    class LayerControl
    {
        LinkedList<Recipe.Ingredient> ingredients;

        public LayerControl()
        {
            ingredients = new LinkedList<Recipe.Ingredient>();
        }

        private void correctLayerOrder()
        {
            LinkedList<Recipe.Ingredient> tempList = new LinkedList<Recipe.Ingredient>();

            for (var node = ingredients.First; node != null; node = node.Next)
            {
                if (node.Next != null)
                {
                    if (node == ingredients.First)
                    {
                        if (node.Next.Value.Layer - node.Value.Layer == 1 || node.Next.Value.Layer == node.Value.Layer)
                        {
                            tempList.AddFirst(new LinkedListNode<Recipe.Ingredient>(node.Value));
                            tempList.AddAfter(tempList.First, new LinkedListNode<Recipe.Ingredient>(node.Next.Value));
                        }
                        else if (node.Value.Layer - node.Next.Value.Layer == 1)
                        {
                            tempList.AddFirst(new LinkedListNode<Recipe.Ingredient>(node.Next.Value));
                            tempList.AddAfter(tempList.First, new LinkedListNode<Recipe.Ingredient>(node.Value));
                        }
                    }
                    else
                    {
                        
                        for (var tempNode = tempList.First; tempNode != null; tempNode = tempNode.Next)
                        {
                            if (!tempList.Contains(node.Value))
                            {
                                if (node.Value.Layer == tempNode.Value.Layer)
                                {
                                    tempList.AddAfter(tempNode, new LinkedListNode<Recipe.Ingredient>(node.Value));
                                }
                                else if (node.Value.Layer - tempNode.Value.Layer == 1)
                                {
                                    tempList.AddAfter(tempNode, new LinkedListNode<Recipe.Ingredient>(node.Value));
                                }
                                else if (tempNode.Value.Layer - node.Value.Layer == 1)
                                {
                                    tempList.AddBefore(tempNode, new LinkedListNode<Recipe.Ingredient>(node.Value));
                                }
                            }
                        }
                    }
                }
                else
                {
                    tempList.AddFirst(new LinkedListNode<Recipe.Ingredient>(node.Value));
                }

            }
            ingredients = tempList;

        }

        public void Add(Recipe.Ingredient ingredient)
        {
            LinkedListNode<Recipe.Ingredient> addIngredient = new LinkedListNode<Recipe.Ingredient>(ingredient);
            if (ingredients.First == null)
            {
                ingredients.AddFirst(addIngredient);
            }
            else if(!ingredients.Contains(addIngredient.Value))
            {

                for (var node = ingredients.First; node != null; node = node.Next)
                {
                    if (!ingredients.Contains(addIngredient.Value))
                    {
                        if (node.Value.Layer == addIngredient.Value.Layer)
                        {
                            ingredients.AddAfter(node, addIngredient);
                        }
                        else if (node.Value.Layer - addIngredient.Value.Layer == 1)
                        {
                            ingredients.AddBefore(node, addIngredient);
                        }
                        else if (addIngredient.Value.Layer - node.Value.Layer == 1)
                        {
                            ingredients.AddAfter(node, addIngredient);
                        }

                    }
                }
            }

          
        }

        public void Draw(Graphics gfx, Point location)
        {
            Image imageToDraw;
            if (ingredients != null)
            {
                for (var node = ingredients.First; node != null; node = node.Next)
                {
                    imageToDraw = Image.FromFile(node.Value.Image);
                    gfx.DrawImage(imageToDraw, location);
                }
            }
        }

    }
}
